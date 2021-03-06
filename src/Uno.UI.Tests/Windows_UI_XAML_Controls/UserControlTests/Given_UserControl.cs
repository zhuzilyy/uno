﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uno.UI.Tests.Windows_UI_XAML_Controls.UserControlTests;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace Uno.UI.Tests.Windows_UI_Xaml_Controls.xLoad
{
	[TestClass]
	public class Given_UserControl
	{
		[TestMethod]
		public void When_UserControl_TopLevel_Binding()
		{
			var sut = new UserControl_TopLevelBinding();
			sut.ForceLoaded();

			var uc01 = sut.FindName("uc01");

			Assert.AreEqual(0, UserControl_TopLevelBinding_AttachedProperty.MyPropertyChangedCount);
			Assert.AreEqual(0, UserControl_TopLevelBinding_AttachedProperty.GetMyProperty(uc01));

			sut.DataContext = 42;

			Assert.AreEqual(1, UserControl_TopLevelBinding_AttachedProperty.MyPropertyChangedCount);
			Assert.AreEqual(42, UserControl_TopLevelBinding_AttachedProperty.GetMyProperty(uc01));
		}
	}
}
