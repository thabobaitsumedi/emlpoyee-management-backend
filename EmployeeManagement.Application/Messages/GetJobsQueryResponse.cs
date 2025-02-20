﻿using System.Collections.Generic;

namespace EmployeeManagement.Application.Messages
{
    public class GetJobsQueryResponse
    {
        public GetJobsQueryResponse()
        {
            Jobs = new List<JobResponse>();
        }

        public List<JobResponse> Jobs { get; set; }
    }

    public class JobResponse
    {
        public int JobId { get; set; }

        public string JobTitle { get; set; }
    }
}