using System;
using System.Linq;

namespace ReverseString {
  public static class ReverseString {
    public static string Reverse(string input) {
      return String.Concat(input.Reverse());
    }
  }
}