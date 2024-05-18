// See https://aka.ms/new-console-template for more information
using DependencyInversion.Notificaciones;

NotificacionSMS notificacionSMS = new NotificacionSMS();
NotificacionPush notificacionPush = new NotificacionPush();
NotificacionEmail notificacionEmail = new NotificacionEmail();
ProcesadorNotificaciones procesadorNotificaciones = new ProcesadorNotificaciones();

procesadorNotificaciones.EnviarSMS(notificacionSMS, "758498756", "777489632", "SMS importante!");
procesadorNotificaciones.EnviarEmail(notificacionEmail, "emisor@gmail.com", "receptor1@gmail.com", "Correo Importante!");
procesadorNotificaciones.EnviarNotificacionPush(notificacionPush, "Admin App", "usuario 1", "Mensaje importante!");
