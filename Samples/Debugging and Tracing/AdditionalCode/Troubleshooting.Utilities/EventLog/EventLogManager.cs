using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


public partial class EventLogManager : Component
{
    public static void Write
    (string message, EventLogEntryType eventType)
    {
        // create instance of this class
        EventLogManager manager = new EventLogManager();
        // call WriteEntry off of generated eventLog1 object property
        manager.eventLog1.WriteEntry(message, eventType);
    }

    public EventLogManager()
    {
        InitializeComponent();
    }

    public EventLogManager(IContainer container)
    {
        container.Add(this);

        InitializeComponent();
    }
}
