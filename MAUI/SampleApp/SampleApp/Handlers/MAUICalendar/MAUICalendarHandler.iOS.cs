#if IOS
using Microsoft.Maui.Handlers;
using SampleApp.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using FSCalendar_API;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;
using Microsoft.Maui.Platform;
using Foundation;

namespace SampleApp.Handlers.MAUICalendar
{
    public partial class MAUICalendarHandler : ViewHandler<MAUICalendarView, FSCalendar>
    {
        private FSCalendar fsCalendar;
        protected override FSCalendar CreatePlatformView()
        {
            fsCalendar = new FSCalendar
            {
                DataSource = new FSCalendarDataSource(),
                Delegate = new FSCalendarDelegate(),
                
            };            
            
            return fsCalendar;
        }
    }

}
#endif