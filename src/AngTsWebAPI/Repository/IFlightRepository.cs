﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngTsWebAPI.Model;

namespace AngTsWebAPI.Repository
{
    public interface IFlightRepository
    {
		void Add(Flight flight);
		List<Flight> FindByGate(int gateid);
		IEnumerable<Flight> GetAll();
		Flight Find(int id);
		void Remove(int id);
		Flight Update(Flight f);
		int GetNewIdentity();

	}
}
