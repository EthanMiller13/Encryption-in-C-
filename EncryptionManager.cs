namespace Encryption{
    class EncryptionManager{
        public int seed;

        public EncryptionManager(int _seed){
            this.seed = _seed;
        }

        public string encrypt(string text, int seed){
            string encrypted = "";

            foreach(char c in text){
                int ascii = (int)c;
                char newchar = (char)(ascii + seed);
                encrypted += newchar;
            }
            return encrypted;
        }

        public string decrypt(string enc, int seed){
            string decrypted = "";

            foreach(char c in enc){
                int ascii = (int)c;
                char newchar = (char)(ascii - seed);
                decrypted += newchar;
            }
            return decrypted;
        }

    }
}