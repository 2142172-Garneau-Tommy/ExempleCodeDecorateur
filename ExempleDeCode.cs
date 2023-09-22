using KrustyKrab;

namespace KrustyKrab
{
    /// <summary>
    /// La classe du menu du restaurant de KrustyKrab 
    /// </summary>
    public abstract class Menu
    {
        /// <summary>
        /// Le prix du hamburger.
        /// </summary>
        public abstract double prix;

        /// <summary>
        //  La description du hamburger.
        /// </summary>
        public abstract string description;
    }

    /// <summary>
    /// Classe du hamburger.
    /// </summary>
    class Hamburger : Menu
    {
        /// <summary>
        /// Crée un nouveau hamburger vide
        /// </summary>
        public Hamburger()
        {
            
        }

        /// <summary>
        /// Le prix du hamburger.
        /// </summary>
        public override double prix = 11.99;

        /// <summary>
        /// La description du hamburger.
        /// </summary>
        public override string description = "Un hamburger";
    }


    /// <summary>
    /// Le décorateur qui va permettre de personnalisé l'hamburger
    /// </summary>
    class Decorateur : Hamburger
    {
        public Hamburger _hamburger;

        /// <summary>
        /// Crée un décorateur qui va permettre de personnalisé l'hamburger
        /// </summary>
        public Decorateur(Hamburger hamburger)
        {
            _hamburger = hamburger;
        }

        /// <summary>
        /// Le prix du hamburger.
        /// </summary>
        public double prix = _hamburger.prix;
        

        /// <summary>
        /// La description du hamburger.
        /// </summary>
        public string description = _hamburger.description;
    }

    /// <summary>
    /// Classe du hamburger qui contient des légumes
    /// </summary>
    class HamburgerLegume : Decorateur
    {
        /// <summary>
        /// Crée un hamburger qui contient un légume.
        /// </summary>
        public HamburgerLegume(Hamburger hamburger) : base(hamburger)
        {

        }

        /// <summary>
        /// Le prix du hamburger.
        /// </summary>
        public override double prix = base.prix + 2;
     

        /// <summary>
        /// La description du hamburger.
        /// </summary>
        public  override string description = base.description + "Un hamburger qui contient un légume";
    }

    /// <summary>
    /// Classe du hamburger qui contient de la viande
    /// </summary>
    class HamburgerViande : Decorateur
    {
        /// <summary>
        /// Crée un hamburger qui contient de la viande.
        /// </summary>
        public HamburgerViande(Hamburger hamburger) : base(hamburger)
        {

        }

        /// <summary>
        /// Le prix du hamburger.
        /// </summary>
        public override double prix = base.prix + 4;

        /// <summary>
        /// La description du hamburger.
        /// </summary>
        public override string description = base.description + "Un hamburger qui contient de la viande";
    }

    /// <summary>
    /// Classe du hamburger qui contient de la sauce
    /// </summary>
    class HamburgerSauce : Decorateur
    {
        /// <summary>
        /// Crée un hamburger qui contient de la sauce.
        /// </summary>
        public HamburgerSauce(Hamburger hamburger) : base(hamburger)
        {

        }

        /// <summary>
        /// Le prix du hamburger.
        /// </summary>
        public override double prix = base.prix + 1.5;

        /// <summary>
        /// La description du hamburger.
        /// </summary>
        public override string description = base.description + "Un hamburger qui contient de la sauce";
    }
}