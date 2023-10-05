﻿using OdontoControl.Core.DTO.AppointmentDTO;
using OdontoControl.Core.DTO.ClinicDTO;
using OdontoControl.Core.DTO.ReminderDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoControl.Core.ServiceContracts.ReminderContracts
{
    public interface IReminderAdderService
    {
        Task<ReminderResponse> AddReminder(ReminderAddRequest? Reminder);
    }
}
