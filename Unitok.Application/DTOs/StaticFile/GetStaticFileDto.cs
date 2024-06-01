using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitok.Application.DTOs.StaticFile
{
	public class GetStaticFileDto
	{
		public string Path { get; set; }
		public string Name { get; set; }
		public string? Extension { get; private set; }
	}
}
