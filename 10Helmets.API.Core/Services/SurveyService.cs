namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class SurveyService : BaseService<Survey>, ISurveyService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="surveyRepository"></param>
        public SurveyService(ISurveyRepository surveyRepository)
            : base(surveyRepository)
        {

        }
    }
}
