using Kotacs.Libraries.SOA.Contracts.Data;
using Kotacs.Libraries.SOA.Contracts.Services;
using Kotacs.Libraries.SOA.Proxies;
using Kotacs.Libraries.Web.Charts.Impl;
using Kotacs.Libraries.Web.Charts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderSystemWeb.Controllers
{
    public class OrderController : KotacsControllerBase
    {
        //
        // GET: /Order/
        private IOrderService orderService = default(IOrderService);
        private IChartService chartService = default(IChartService);

        public OrderController(IOrderService orderService,IChartService chartService)
        {
            //orderService = new OrderServiceProxy();
            //chartService = new WebChartService();

            this.orderService = orderService;
            this.chartService = chartService;
        }
        public ActionResult Index()
        {
            if (orderService != default(IOrderService))
            {
                var orders = orderService.GetAllOrders();
                return View(model: orders);
            }
            return View(viewName: "Error");
        }
        [ActionName("OrderDetails")]
        public ActionResult GetOrders(string customerId)
        {
            if(orderService!=default(IOrderService)&& !string.IsNullOrEmpty(customerId))
            {
                var orders = orderService.GetOrders(customerId);
                ViewBag.customerId = customerId;
                return View(model: orders);
            }
            return View(viewName:"Error");
        }
        [ActionName("OrderDetailsChart")]
        public void GetCustomerOrdersChart(string customerId)
        {
            if (orderService != default(IOrderService) &&
                chartService != default(IChartService) && !string.IsNullOrEmpty(customerId))
            {
                var ordersList = orderService.GetOrders(customerId);

                var xValue = ordersList.Select<Order, string>(order => order.OrderId).ToArray();
                var yValues = ordersList.Select<Order, int>(order => order.OrderValue).ToList();

                chartService.Render(
                    "Column", "Order Performance Analysis", xValue, yValues);
            }
        }

        //public IChartService chartService { get; set; }
    }
}
