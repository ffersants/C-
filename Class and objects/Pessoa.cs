namespace Class_and_objects
{
    class Pessoa
    {
        public int birthYear;
        public Pessoa(int birthYear)
        {
            this.birthYear = birthYear;
        }

        public static int getAge(int birth)
        {
            return 2020 - birth;
        }
    }
}