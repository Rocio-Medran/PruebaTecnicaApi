﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppModels.DTOs
{
	public class CategoriaDTO
	{
		public int Id { get; set; }

		public string Nombre { get; set; }
	}
}
