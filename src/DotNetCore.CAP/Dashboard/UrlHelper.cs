﻿using System;

namespace DotNetCore.CAP.Dashboard
{
    public class UrlHelper
    {
        private readonly DashboardContext _context;

        public UrlHelper(DashboardContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            _context = context;
        }

        public string To(string relativePath)
        {
            return
                _context.Request.PathBase
                + relativePath;
        }

        public string Home()
        {
            return To("/");
        }

        public string JobDetails(string jobId)
        {
            return To("/jobs/details/" + jobId);
        }

        public string NodeSwitch(string id)
        {
            return To("/nodes/node/" + id);
        }

        public string LinkToPublished()
        {
            return To("/published/succeeded");
        }

        public string LinkToReceived()
        {
            return To("/received/succeeded");
        }

        public string Queue(string queue)
        {
            return To("/jobs/enqueued/" + queue);
        }
    }
}