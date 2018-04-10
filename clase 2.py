# -*- coding: utf-8 -*-

def inscripciones (curso , alumno):
    if alumno in curso:
        print 'El alumno', alumno, 'ya esta inscrito en el curso'
    else:
        print curso['alumnos']
        curso['alumnos'].append(alumno)

cursos = {'nombre':'programacion','alumnos':[]}
programacion = []
for i in range(2):
    nombre = raw_input('Ingrese el nombre del alumno: ')
    
    inscripciones(cursos, nombre)
print programacion
print cursos
