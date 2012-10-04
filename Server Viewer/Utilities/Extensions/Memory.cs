using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace LoginServer
{
    public static class MemoryStreamExtensions
    {
        public static void AddByte(this MemoryStream stream, byte value)
        {
            stream.AddBytes(new[] { value });
        }

        public static void AddByte(this MemoryStream stream, sbyte value)
        {
            byte result;
            if (value == -1) result = 0xFF;
            else result = Convert.ToByte(value);
            stream.AddBytes(new[] { result });
        }

        public static void AddBytes(this MemoryStream stream, byte[] values)
        {
            stream.Write(values, 0, values.Length);
        }

        public static void AddInt64(this MemoryStream stream, Int64 value)
        {
            stream.Write(BitConverter.GetBytes(value).Reverse().ToArray(), 0, BitConverter.GetBytes(value).Reverse().ToArray().Length);
        }

        public static void AddInt32(this MemoryStream stream, int value)
        {
            stream.Write(BitConverter.GetBytes(value).Reverse().ToArray(), 0, BitConverter.GetBytes(value).Reverse().ToArray().Length);
        }

        public static void AddInt32(this MemoryStream[] stream, int value)
        {
            stream[0].Write(BitConverter.GetBytes(value).Reverse().ToArray(), 0, BitConverter.GetBytes(value).Reverse().ToArray().Length);
        }

        public static void AddInt32r(this MemoryStream stream, int value)
        {
            stream.Write(BitConverter.GetBytes(value), 0, BitConverter.GetBytes(value).Length);
        }

        public static void AddInt16(this MemoryStream stream, Int16 value)
        {
            stream.Write(BitConverter.GetBytes(value).Reverse().ToArray(), 0, BitConverter.GetBytes(value).Reverse().ToArray().Length);
        }

        public static void AddFloat(this MemoryStream stream, float value)
        {
            stream.Write(BitConverter.GetBytes(value), 0, 4);
        }

        public static void AddString(this MemoryStream stream, string value)
        {
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            stream.Write(encoding.GetBytes(value), 0, encoding.GetBytes(value).Length);
        }

        public static string ReadString(this byte[] stream, int position)
        {
            int a = 0;

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();

            while (stream[position] != 0x00)
            {
                a++;
                position++;
            }

            byte[] text = new byte[a];
            Array.Copy(stream, position - a, text, 0, a);

            return encoding.GetString(text);
        }

        public static int GetInt32(this byte[] bytes, int Position)
        {
            byte[] raw = new byte[4];
            Array.Copy(bytes, Position, raw, 0, 4);

            byte[] number = raw.Reverse().ToArray();

            return BitConverter.ToInt32(number, 0);
        }

        public static Int64 GetInt64(this byte[] bytes, int Position)
        {
            byte[] raw = new byte[8];
            Array.Copy(bytes, Position, raw, 0, 8);

            byte[] number = raw.Reverse().ToArray();

            return BitConverter.ToInt64(number, 0);
        }

        public static float GetFloat(this byte[] bytes, int Position)
        {
            byte[] raw = new byte[4];
            Array.Copy(bytes, Position, raw, 0, 4);

            return BitConverter.ToSingle(raw, 0);
        }
    }
}