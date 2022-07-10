
namespace MainAssembly{
    class MainProgram{
        public static void Main(string[] args){
            Random rand = new Random();
            Encryption.EncryptionManager manager = new Encryption.EncryptionManager(rand.Next(1, 100));
            string my_text = "Hi there! I'm Ethan and I've created this program!";
            string enc = manager.encrypt(my_text, manager.seed);
            string dec = manager.decrypt(enc, manager.seed);
            Console.WriteLine("Encrypted: " + enc);
            Console.WriteLine("Decrypted: " + dec);
        }
    }
}