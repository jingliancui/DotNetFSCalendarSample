using System;
using SampleApp.Controls;
using Xamarin.Forms.Platform.iOS;
using FSCalendar_API;
using Xamarin.Forms;
using SampleApp.iOS.Renderers;

[assembly: ExportRenderer(typeof(XCalendarView), typeof(XCalendarViewRenderer))]
namespace SampleApp.iOS.Renderers
{
    public class XCalendarViewRenderer:ViewRenderer<XCalendarView, FSCalendar>
    {
        private FSCalendar fSCalendar;

        protected override void OnElementChanged(ElementChangedEventArgs<XCalendarView> e)
        {
            fSCalendar = new FSCalendar
            {
                Frame = new CoreGraphics.CGRect(0,0,320,300),
                DataSource=new FSCalendarDataSource(),
                Delegate=new FSCalendarDelegate()
            };
            SetNativeControl(fSCalendar);
        }
    }
}
