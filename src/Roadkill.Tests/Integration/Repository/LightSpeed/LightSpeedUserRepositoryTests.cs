﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindscape.LightSpeed;
using NUnit.Framework;
using Roadkill.Core.Configuration;
using Roadkill.Core.Database.LightSpeed;
using Roadkill.Core.Database.MongoDB;
using IRepository = Roadkill.Core.Database.IRepository;

namespace Roadkill.Tests.Integration.Repository.LightSpeed
{
	[TestFixture]
	[Category("Integration")]
	public class LightSpeedUserRepositoryTests : UserRepositoryTests
	{
		protected override string ConnectionString
		{
			get { return SqlServerSetup.ConnectionString; }
		}

		protected override IRepository GetRepository()
		{
			return new LightSpeedRepository(DataProvider.SqlServer2008, ApplicationSettings.ConnectionString);
		}

		protected override void Clearup()
		{
			SqlServerSetup.ClearDatabase();
		}
	}
}
