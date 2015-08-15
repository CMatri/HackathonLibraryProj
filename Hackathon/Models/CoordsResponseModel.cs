using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Models
{
    public class CoordsResponseModel
    {
        public ResponseData[] data;
    
        public CoordsResponseModel(ResponseData[] data)
        {
            this.data = data;
        }
    }

    public class ResponseData
    {
        public string url;
        public string title;
        public string subject;
        public string description;
        public string publisher;
        public string date;
        public string id;

        public string[] spatial_coverage;
        public string[] tags;
    }
}