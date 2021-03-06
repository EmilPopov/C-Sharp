﻿//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the 
//string with the first of the key, the second – with the second, etc.
//When the last key character is reached, the next is the first.
using System;
using System.Text;


namespace Encode_Decode
{
    class EncodeDecode
    {
        static void Main()
        {
            string message = "(The Gospel of John, chapter 1) 1 In the beginning the Word already existed. He was with God, and he was God. 2 He was in the beginning with God. 3 He created everything there is. Nothing exists that he didn't make. 4 Life itself was in him, and this life gives light to everyone. 5 The light shines through the darkness, and the darkness can never extinguish it. 6 God sent John the Baptist 7 to tell everyone about the light so that everyone might believe because of his testimony. 8 John himself was not the light; he was only a witness to the light. 9 The one who is the true light, who gives light to everyone, was going to come into the world. 10 But although the world was made through him, the world didn't recognize him when he came. 11 Even in his own land and among his own people, he was not accepted. 12 But to all who believed him and accepted him, he gave the right to become children of God. 13 They are reborn! This is not a physical birth resulting from human passion or plan, this rebirth comes from God.14 So the Word became human and lived here on earth among us. He was full of unfailing love and faithfulness. And we have seen his glory, the glory of the only Son of the Father.";
            string key = "god";

            Console.WriteLine(Decrypt(Encrypt(message, key), key));
        }
        static string Encrypt(string message, string key)
        {
            var encryptedMessage = new StringBuilder(message.Length);

            for (int i = 0; i < message.Length; i++)
                encryptedMessage.Append((char)(message[i] ^ key[i % key.Length]));

            return encryptedMessage.ToString();
        }

        static string Decrypt(string message, string key)
        {
            return Encrypt(message, key);
        }
    }
}
