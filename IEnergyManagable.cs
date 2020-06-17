namespace BuildingHouse
{
    interface IEnergyManagable
    {
        int Energy { get; set; }

        int GetEnergyLevel();
        int SetEnergyLevel();
    
    }
}
