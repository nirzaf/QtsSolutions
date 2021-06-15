﻿namespace QtsSolutions.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly QtsSolutionsDbContext _context;

        public InitialHostDbBuilder(QtsSolutionsDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
