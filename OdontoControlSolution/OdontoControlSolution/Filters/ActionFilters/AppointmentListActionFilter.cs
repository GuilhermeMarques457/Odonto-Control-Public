﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OdontoControl.Controllers;
using OdontoControl.Core.DTO.AppointmentDTO;
using OdontoControl.Core.Enums;
using OdontoControl.UI.Areas.Admin.Controllers;

namespace OdontoControl.UI.Filters.ActionFilters
{
    public class AppointmentsListActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await next();

            Controller? controller = null;

            if (context.Controller is AppointmentController appointmentController)
            {
                controller = appointmentController;
            }
            else if(context.Controller is HomeController homeController)
            {
                controller = homeController;
            }

            if(controller != null)
            {
                controller.ViewBag.SearchFields = new Dictionary<string, string>()
                {
                    { nameof(AppointmentResponse.Patient.PatientName), "Paciente" },
                    { nameof(AppointmentResponse.Dentist.DentistName), "Dentista" },
                    { nameof(AppointmentResponse.StartTime), "Hora da entrada" },
                    { nameof(AppointmentResponse.EndTime), "Hora da saída" },
                    { nameof(AppointmentResponse.ProcedureType), "Procedimento" },
                    { nameof(AppointmentResponse.Status), "Status" },
                };

                if(controller is AppointmentController)
                {
                    controller.ViewBag.SearchFields.Add(nameof(AppointmentResponse.AppointmentTime), "Data da consulta");
                }
            }

           
        }
    }
}
