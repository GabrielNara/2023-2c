﻿using Clase6.EF.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6.EF.Logica;

public interface IUbicacionServicio
{
    void Agregar(Ubicacion ubicacion);
    List<Ubicacion> ObtenerTodos();
    Ubicacion ObtenerPorId(int id);
    void Actualizar(Ubicacion ubicacion);
    void Eliminar(int id);
}

public class UbicacionServicio : IUbicacionServicio
{
    private Pw32cIslaTesoroContext _context;

    public UbicacionServicio(Pw32cIslaTesoroContext context)
    {
        this._context = context;
    }


    public void Actualizar(Ubicacion ubicacion)
    {
        this._context.Ubicacions.Update(ubicacion);
        this._context.SaveChanges();
    }

    public void Agregar(Ubicacion ubicacion)
    {
        this._context.Ubicacions.Add(ubicacion);
        this._context.SaveChanges();
    }

    public void Eliminar(int id)
    {
        var ubicacion = this.ObtenerPorId(id);

        if (ubicacion == null)
            return;

        this._context.Ubicacions.Remove(ubicacion);
        this._context.SaveChanges();
    }

    public Ubicacion ObtenerPorId(int id)
    {
        return this._context.Ubicacions.Find(id);
    }

    public List<Ubicacion> ObtenerTodos()
    {
        return this._context.Ubicacions.ToList();
    }
}