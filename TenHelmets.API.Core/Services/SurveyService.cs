﻿using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public class SurveyService : BaseService<Survey>, ISurveyService
    {
        public SurveyService(ISurveyRepository surveyRepository)
            : base(surveyRepository)
        {

        }
    }
}
