﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoadWordTemplate.Entities;
using LoadWordTemplate.Repositories;

namespace LoadWordTemplate.Business
{
    public class CumpleaniosCartaBusiness
    {
        private CumpleaniosCartaRepository cartaCumpleaniosRepository = null;
        public CumpleaniosCartaBusiness(string pathDocumentoPdf)
        {
            cartaCumpleaniosRepository = new CumpleaniosCartaRepository(pathDocumentoPdf);
        }

        public void CrearCartasCumpleanios(IEnumerable<CartaEntity> listaCartas)
        {
            try
            {
                cartaCumpleaniosRepository.GenerarCarta(listaCartas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
