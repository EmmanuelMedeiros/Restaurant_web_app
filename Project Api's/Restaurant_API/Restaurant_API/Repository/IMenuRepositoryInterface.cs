﻿using Restaurant_API.Models;

namespace Restaurant_API.Repository {
    public interface IMenuRepositoryInterface {

        List<PratoCompleto> GetAllPratosCompletos();
        PratoCompleto GetPratoCompletoById(int id);
        Guarnicao GetGuarnicaoById(int id);
        List<Guarnicao> GetAllGuarnicoes();
    }
}
