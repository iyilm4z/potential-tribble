﻿using DowntimeAlerter.Engine;
using DowntimeAlerter.Seed;

namespace DowntimeAlerter
{
    public class DbSeedingStartupTask : IStartupTask
    {
        public void Execute()
        {
            var dbContext = EngineContext.Current.Resolve<IDbContext>() as AppDbContext;

            SeedHelper.Seed(dbContext);
        }

        public int Order => 4;
    }
}
