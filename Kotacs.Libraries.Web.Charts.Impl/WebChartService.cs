using Kotacs.Libraries.Web.Charts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Helpers;

namespace Kotacs.Libraries.Web.Charts.Impl
{
    public class WebChartService : IChartService
    {
        //public void Render(string chartType, string chartTitle, string[] xValue, IEnumerable<int> yvalues);
        public void Render(string chartType, string chartTitle,string[] xValue, IEnumerable<int>yValues)
        {
            var chartTheme = @"";
                    //<Chart BackColor='#FADA5E' BackGradientStyle='TopBottom' 
                    //       BorderColor='#B8860B' BorderWidth='2' BorderlineDashStyle='Solid' 
                    //       Palette='EarthTones'>
                    //    <ChartAreas>
                    //        <ChartArea Name='Default' _Template_='All' 
                    //            BackColor='Transparent' BackSecondaryColor='White' 
                    //            BorderColor='64, 64, 64, 64' BorderDashStyle='Solid' ShadowColor='Transparent'>
                    //            <AxisY>
                    //                <LabelStyle Font='Trebuchet MS, 8.25pt, style=Bold' />
                    //            </AxisY>
                                
                    //            <AxisX LineColor='64, 64, 64, 64'>
                    //                <LabelStyle Font='Trebuchet MS, 8.25pt, style=Bold' />
                    //            </AxisX>
                    //        </ChartArea>
                    //    </ChartAreas>
                    //    <Legends>
                    //        <Legend _Template_='All' BackColor='Transparent' 
                    //            Docking='Bottom' Font='Trebuchet MS, 8.25pt, style=Bold' LegendStyle='Row'>
                    //        </Legend>
                    //    </Legends>
                    //    <BorderSkin SkinStyle='Emboss' />
                    //</Chart>";
            var webChart = new Chart(width:300,height:200,theme:chartTheme);
            webChart.AddSeries(name:chartTitle,chartType: chartType,xValue: xValue,yValues: yValues);
            webChart.Write(format:"jpeg");
        }
    }
}
