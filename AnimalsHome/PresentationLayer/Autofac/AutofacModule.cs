using Autofac;
using AutoMapper;
using BL.Model;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Autofac
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder) 
        { 
            builder.Register(context => new MapperConfiguration(cfg => 
            { 
                cfg.CreateMap<HomeModel, Home>().ReverseMap(); })).AsSelf().SingleInstance();  //??
            
            builder.Register(c => 
            { 
                var context = c.Resolve<IComponentContext>(); 
                var config = context.Resolve<MapperConfiguration>(); 
                return config.CreateMapper(context.Resolve); }).As<IMapper>().InstancePerLifetimeScope(); }
    }
}