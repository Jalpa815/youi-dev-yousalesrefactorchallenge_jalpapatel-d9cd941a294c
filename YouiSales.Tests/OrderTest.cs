﻿using System;
using NUnit.Framework;
using Shouldly;

namespace YouiSales.Tests
{
    [TestFixture]
    public class OrderTest
    {
        private readonly static CarPolicy BMW = new CarPolicy("Jane Doe", "BMW", CarPolicy.Car);
        private readonly static MotorCyclePolicy Harley = new MotorCyclePolicy("John Doe", "Harley", MotorCyclePolicy.Motorcycle);
        private readonly static HomePolicy SunnyCoast = new HomePolicy("John Doe", "Sunshine Coast", HomePolicy.Home);

        [Test]
        public void ReceiptOneBMW()
        {
            var order = new Order("Youi");
            order.AddLine(new Line(BMW, 1));
            order.Receipt().ShouldBe(ResultStatementOneBMW);
        }

        private const string ResultStatementOneBMW = @"Order Receipt for Youi
	1 x Jane Doe BMW = $105.00
Sub-Total: $105.00
Tax: $10.50
Total: $115.50
Date: Friday, 25 October 2019 9:07:27 AM";

        [Test]
        public void ReceiptOneHarley()
        {
            var order = new Order("Youi");
            order.AddLine(new Line(Harley, 1));
            order.Receipt().ShouldBe(ResultStatementOneHarley);
        }

        private const string ResultStatementOneHarley = @"Order Receipt for Youi
	1 x John Doe Harley = $56.00
Sub-Total: $56.00
Tax: $5.60
Total: $61.60
Date: Friday, 25 October 2019 9:07:27 AM";

        [Test]
        public void ReceiptOneSunnyCoast()
        {
            var order = new Order("Youi");
            order.AddLine(new Line(SunnyCoast, 1));
            order.Receipt().ShouldBe(ResultStatementOneSunnyCoast);
        }

        private const string ResultStatementOneSunnyCoast = @"Order Receipt for Youi
	1 x John Doe Sunshine Coast = $235.00
Sub-Total: $235.00
Tax: $23.50
Total: $258.50
Date: Friday, 25 October 2019 9:07:27 AM";

        [Test]
        public void HtmlReceiptOneBMW()
        {
            var order = new Order("Youi");
            order.AddLine(new Line(BMW, 1));
            order.HtmlReceipt().ShouldBe(HtmlResultStatementOneBMW);
        }

        private const string HtmlResultStatementOneBMW = @"<html><body><h1>Order Receipt for Youi</h1><ul><li>1 x Jane Doe BMW = $105.00</li></ul><h3>Sub-Total: $105.00</h3><h3>Tax: $10.50</h3><h2>Total: $115.50</h2><h3>Date: Friday, 25 October 2019 9:07:27 AM</h3></body></html>";

        [Test]
        public void HtmlReceiptOneHarley()
        {
            var order = new Order("Youi");
            order.AddLine(new Line(Harley, 1));
            order.HtmlReceipt().ShouldBe(HtmlResultStatementOneHarley);
        }

        private const string HtmlResultStatementOneHarley = @"<html><body><h1>Order Receipt for Youi</h1><ul><li>1 x John Doe Harley = $56.00</li></ul><h3>Sub-Total: $56.00</h3><h3>Tax: $5.60</h3><h2>Total: $61.60</h2><h3>Date: Friday, 25 October 2019 9:07:27 AM</h3></body></html>";

        [Test]
        public void HtmlReceiptOneSunnyCoast()
        {
            var order = new Order("Youi");
            order.AddLine(new Line(SunnyCoast, 1));
            order.HtmlReceipt().ShouldBe(HtmlResultStatementOneSunnyCoast);
        }

        private const string HtmlResultStatementOneSunnyCoast = @"<html><body><h1>Order Receipt for Youi</h1><ul><li>1 x John Doe Sunshine Coast = $235.00</li></ul><h3>Sub-Total: $235.00</h3><h3>Tax: $23.50</h3><h2>Total: $258.50</h2><h3>Date: Friday, 25 October 2019 9:07:27 AM</h3></body></html>";
    }
}
