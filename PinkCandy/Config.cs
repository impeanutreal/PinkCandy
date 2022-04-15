using Exiled.API.Interfaces;
using System.ComponentModel;

namespace PinkCandy
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}