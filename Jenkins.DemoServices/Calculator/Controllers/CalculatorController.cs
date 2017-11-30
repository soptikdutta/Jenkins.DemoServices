using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Calculator.Controllers
{
    public class CalculatorController : ApiController
    {
        #region variable initialization
       

        #endregion variable initialization

        #region GetMethods

        /// <summary>
        /// To get the details of the survey
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>        
        [Route("{id}", Name = "GetbyId")]
        [HttpGet]
        public async Task<ApiResult<int>> Get(string id)
        {
            //SurveyView srvyModel = await SurveyActor.GetSurvey(id, new MultibannerContext());
            //return 32; //await //this.CreateResponse(srvyModel, "Success");
            return await this.CreateResponse(32, "Success");

        }

        #endregion GetMethods

        

    }
}
