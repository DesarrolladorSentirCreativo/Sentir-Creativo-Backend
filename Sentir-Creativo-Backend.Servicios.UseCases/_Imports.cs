﻿global using FluentValidation;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Create;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.Ocacions;
global using Sentir_Creativo_Backend.Servicios.Entities.POCOEntities;
global using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
global using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Update;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.Ocaciones;
global using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;

//tecnicas artisticas
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Create;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.TecnicaArtisticas;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Delete;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.TecnicaArtisticas;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetAll;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Update;
global using Microsoft.Extensions.DependencyInjection;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Select;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetById;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Select;
global using Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.Select;
global using Sentir_Creativo_Backend.Servicios.UseCases.Formatos.Select;
global using Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.Create;
global using Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.Delete;
global using Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.GetAll;
global using Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.GetById;
global using Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.Select;
global using Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.Update;


//ocaciones
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.GetAll;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.Ocaciones;
global using Sentir_Creativo_Backend.Servicios.UseCases.Ocacions.Create;
global using Sentir_Creativo_Backend.Servicios.UseCases.Ocacions.Update;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Delete;
global using Sentir_Creativo_Backend.Servicios.UseCases.Ocacions.Delete;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Select;
global using Sentir_Creativo_Backend.Servicios.UseCases.Ocacions.GetAll;
global using Sentir_Creativo_Backend.Servicios.UseCases.Ocacions.Select;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.GetById;
global using Sentir_Creativo_Backend.Servicios.UseCases.Ocacions.GetById;

//estados servicios
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.EstadosServicios;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Create;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.EstadoServicios;
global using Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.Create;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Update;
global using Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.Update;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Delete;
global using Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.Delete;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.EstadoServicios;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.GetAll;
global using Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.GetAll;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.GetById;
global using Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.GetById;

//formatos
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.Formatos;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Select;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Create;
global using Sentir_Creativo_Backend.Servicios.UseCases.Formatos.Create;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Update;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.Formatos;
global using Sentir_Creativo_Backend.Servicios.UseCases.Formatos.Update;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Delete;
global using Sentir_Creativo_Backend.Servicios.UseCases.Formatos.Delete;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.GetAll;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.Formatos;
global using Sentir_Creativo_Backend.Servicios.UseCases.Formatos.GetAll;
global using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.GetById;
global using Sentir_Creativo_Backend.Servicios.UseCases.Formatos.GetById;


