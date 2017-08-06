using System.Collections.Generic;

namespace ReturnJsonFromPost.Models
{
    public class MyModel
    { 
        public int Id { get; set; }
        public string Data { get; set; }
    }

    public class MyViewModel
    {
        public string ErrorMessage { get; set; }
        public IEnumerable<MyModel> Models { get; set; }
    }
}
