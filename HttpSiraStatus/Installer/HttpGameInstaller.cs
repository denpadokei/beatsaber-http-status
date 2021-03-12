﻿using HttpSiraStatus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpSiraStatus.Installer
{
    public class HttpGameInstaller : Zenject.Installer
    {
        public override void InstallBindings()
        {
            this.Container.BindInterfacesAndSelfTo<GamePlayDataManager>().AsCached();
            this.Container.BindMemoryPool<CustomCutBuffer, CustomCutBuffer.Pool>().WithInitialSize(90);
        }
    }
}