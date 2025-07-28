using System;
using System.Collections.Generic;

namespace CyberSecurityChatbot
{
    public static class SentimentAnalyzer
    {
        private static readonly Dictionary<string, string> SentimentResponses = new Dictionary<string, string>
        {
            { "worried", "It's completely understandable to feel worried. Cybersecurity can seem overwhelming, but you're not alone." },
            { "anxious", "No need to be anxious! Taking small steps to protect yourself online goes a long way." },
            { "scared", "Cyber threats can be scary, but with the right habits, you can stay safe." },
            { "confused", "Let’s clear things up! I'm here to help you understand any cybersecurity concept." },
            { "frustrated", "I know tech can be frustrating. Let’s tackle your concerns one step at a time." },
            { "nervous", "Feeling nervous is okay. Let me share some tips to ease your mind." },
            { "curious", "Curiosity is the first step to learning. Ask me anything about cybersecurity!" },
            { "unsure", "Let’s walk through it together. Cyber safety doesn’t have to be complicated." },
            { "overwhelmed", "Cybersecurity covers a lot, but I’ll guide you through it simply." },
            { "angry", "I get that cybersecurity issues can make people angry. Let’s work through it." }
        };

        public static string DetectSentiment(string input)
        {
            foreach (var word in SentimentResponses.Keys)
            {
                if (input.Contains(word))
                    return word;
            }
            return null;
        }

        public static string GetResponse(string sentiment)
        {
            if (SentimentResponses.ContainsKey(sentiment))
                return SentimentResponses[sentiment];

            return null;
        }
    }
}
