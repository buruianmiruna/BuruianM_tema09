using System;

namespace SlotMachine_App.Logic
{
    public class SlotGame
    {
        private Random random;
        private SlotItem[] simboluriCurente;
        private int cicluriRamase;
        private double accumulatedTime;
        private double cycleTime = 0.5;

        public bool IsRolling { get; private set; }

        public event Action<SlotItem[]> OnCicluComplet;
        public event Action<bool, SlotItem[]> OnJocComplet;

        public SlotGame()
        {
            random = new Random();
            simboluriCurente = new SlotItem[3];
            IsRolling = false;
            accumulatedTime = 0;
        }

        public void Trage(int nrCicluri)
        {
            cicluriRamase = nrCicluri;
            IsRolling = true;
            accumulatedTime = 0;
        }

        public void Update(double deltaTime)
        {
            if (!IsRolling) return;

            accumulatedTime += deltaTime;

            if (accumulatedTime >= cycleTime)
            {
                accumulatedTime -= cycleTime;
                ExecutaCiclu();
            }
        }

        private void ExecutaCiclu()
        {
            // Generează simboluri aleatorii
            simboluriCurente[0] = SlotItemHelper.GetRandom(random);
            simboluriCurente[1] = SlotItemHelper.GetRandom(random);
            simboluriCurente[2] = SlotItemHelper.GetRandom(random);

            cicluriRamase--;

            // Notifică că un ciclu s-a completat
            OnCicluComplet?.Invoke(simboluriCurente);

            // Verifică dacă jocul s-a terminat
            if (cicluriRamase <= 0)
            {
                IsRolling = false;
                bool aCastigat = VerificaCastig(simboluriCurente);
                OnJocComplet?.Invoke(aCastigat, simboluriCurente);
            }
        }

        private bool VerificaCastig(SlotItem[] simboluri)
        {
            return simboluri[0] == simboluri[1] && simboluri[1] == simboluri[2];
        }

        public SlotItem[] GetSimboluri()
        {
            return simboluriCurente;
        }

        public int GetCicluriRamase()
        {
            return cicluriRamase;
        }
    }
}
