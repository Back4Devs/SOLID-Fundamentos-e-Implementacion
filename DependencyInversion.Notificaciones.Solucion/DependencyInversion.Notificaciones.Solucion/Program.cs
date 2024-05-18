// See https://aka.ms/new-console-template for more information
using DependencyInversion.Notificaciones;
using DependencyInversion.Notificaciones.Solucion;

INotificacion notificacionSMS = new NotificacionSMS();
INotificacion notificacionPush = new NotificacionPush();
INotificacion notificacionEmail = new NotificacionEmail();
ProcesadorNotificaciones procesadorNotificaciones = new ProcesadorNotificaciones();

procesadorNotificaciones.EnviarNotificacion(notificacionSMS, "758498756", "777489632", "SMS importante!");
procesadorNotificaciones.EnviarNotificacion(notificacionEmail, "emisor@gmail.com", "receptor1@gmail.com", "Correo Importante!");
procesadorNotificaciones.EnviarNotificacion(notificacionPush, "Admin App", "usuario 1", "Mensaje importante!");
