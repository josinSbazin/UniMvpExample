using System;
using Fight.Scripts.Manager;
using Fight.Scripts.Model;
using Fight.Scripts.View;
using Leopotam.Math;
using Mvp;
using UniRx;
using UnityEngine;

namespace Fight.Scripts.Presenter
{
    public class SinusoidPresenter : PresenterBase<SinusoidView, SinusoidPresenter>
    {
        private TimeManager _time;
        private SinusoidModel _model;
        private float _speed;
        private float _toSpeedSmooth;
        private IDisposable _toSpeedWork;

        public override void Init(SinusoidView view)
        {
            base.Init(view);

            _time = TimeManager.Instance;
            _model = ModelManager.Instance.GetModel<SinusoidModel>();
            _speed = _model.StartSpeed;
            _toSpeedSmooth = _model.ToSpeedSmooth;

            _model.CurrentSpeed.Subscribe(ToSpeed);

            Observable.EveryUpdate()
                .SkipWhile(_ => TimeManager.Instance.IsPaused)
                .Subscribe(_ => Move())
                .AddTo(View);
        }

        private void Move()
        {
            float newPos = Mathf.Repeat(_time.Time * _speed, 1f);
            View.SetPosition(newPos);
            _model.Position = newPos;
        }

        private void ToSpeed(float toSpeedValue)
        {
            if (_toSpeedWork != null)
            {
                _toSpeedWork.Dispose();
            }

            _toSpeedWork = Observable
                .EveryUpdate()
                .SkipWhile(_ => TimeManager.Instance.IsPaused)
                .TakeWhile(_ => _speed < toSpeedValue)
                .Subscribe(_ =>
                {
                    _speed = MathFast.Lerp(_speed, toSpeedValue, _toSpeedSmooth * Time.deltaTime);
                });
        }
    }
}