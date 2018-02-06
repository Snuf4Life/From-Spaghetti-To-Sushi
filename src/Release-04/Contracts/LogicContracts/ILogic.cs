using LogicContracts;
using System;

namespace LogicContract
{
    public interface ILogic
    {
        IBuilder CreateBuilder();
    }
}
