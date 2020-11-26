package com.airflights.users.model;

import Shared.Airplane;

import java.util.List;

public interface AirplaneMiddleware
{
  List<Airplane> getPlanes();
  Airplane getAirplaneByType(String type);
}
