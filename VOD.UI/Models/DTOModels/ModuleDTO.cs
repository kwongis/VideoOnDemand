using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VOD.UI.Models.DTOModels
{
    public class ModuleDTO
    {
        public int id { get; set; }
        public string ModuleTitle { get; set; }
        public List<VideoDTO> Videos { get; set; }
        public List<DownloadDTO> Downloads { get; set; }
    }
}
