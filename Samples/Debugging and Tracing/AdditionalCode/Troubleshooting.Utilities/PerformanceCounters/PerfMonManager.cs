using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


public partial class PerfMonManager : Component
{

    private static PerformanceCounter _CustomCounter;
    public static PerformanceCounter CustomCounter
    {
        get
        {
            if (_CustomCounter==null)
            {
                _CustomCounter = new PerfMonManager().performanceCounter1;
            }
            return _CustomCounter;
        }
    }

    public PerfMonManager()
    {
        InitializeComponent();
    }

    public PerfMonManager(IContainer container)
    {
        container.Add(this);

        InitializeComponent();
    }
}

