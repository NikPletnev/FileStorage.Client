using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FileStorage.Client.BLL.Models
{
    public class StoredFileModel
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public int UserId { get; set; }

    }
}
