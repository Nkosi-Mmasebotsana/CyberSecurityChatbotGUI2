using System;
using System.Collections.Generic;

namespace CyberSecurityChatbot
{
    public class ChatBot
    {
        private string currentTopicKey = null;
        private string userName = "friend";

        public void SetUserName(string name)
        {
            userName = string.IsNullOrWhiteSpace(name) ? "friend" : name;
            Memory.StoreUserName(userName);
        }

        public string GetWelcomeMessage()
        {
            return $"Welcome, {userName}! I'm here to help you stay safe online.\n" +
                   "I can provide tips on these cybersecurity topics:\n" +
                   string.Join("\n", new[]
                   {
                       "1. Passwords",
                       "2. Phishing",
                       "3. Safe Browsing",
                       "4. Social Media Security",
                       "5. Public Wi-Fi Safety",
                       "6. Malware Protection",
                       "7. Data Backup",
                       "8. Two-Factor Authentication",
                       "9. Software Updates",
                       "10. Online Shopping Safety"
                   });
        }

        public string GetResponse(string input)
        {
            input = input.ToLower();
            string response = "";

            if (string.IsNullOrWhiteSpace(input))
                return "I didn't quite understand that. Could you rephrase?";

            if (input.Contains("exit") || input.Contains("quit"))
                return "Thank you for chatting with me. Stay safe online! 👋";

            if (input.Contains("how are you"))
                return "I'm just code, but always ready to help!";

            if (input.Contains("purpose"))
                return "I help raise awareness about cybersecurity.";

            //Detect sentiment word first
            string detectedSentiment = SentimentAnalyzer.DetectSentiment(input);

            // Detect if input mentions a topic keyword
            string detectedTopic = null;
            if (input.Contains("password") || input.Contains("1"))
                detectedTopic = "password";
            else if (input.Contains("phishing") || input.Contains("2"))
                detectedTopic = "phishing";
            else if (input.Contains("browsing") || input.Contains("3"))
                detectedTopic = "browsing";
            else if (input.Contains("social media") || input.Contains("4"))
                detectedTopic = "social media";
            else if (input.Contains("wifi") || input.Contains("5"))
                detectedTopic = "wifi";
            else if (input.Contains("malware") || input.Contains("6"))
                detectedTopic = "malware";
            else if (input.Contains("backup") || input.Contains("7"))
                detectedTopic = "backup";
            else if (input.Contains("two-factor") || input.Contains("2fa") || input.Contains("8"))
                detectedTopic = "two-factor";
            else if (input.Contains("software update") || input.Contains("9"))
                detectedTopic = "update";
            else if (input.Contains("shopping") || input.Contains("10"))
                detectedTopic = "shopping";

            // Respond differently if sentiment is detected without topic
            if (detectedSentiment != null && detectedTopic == null)
            {
                // Just sentiment, no topic
                response += SentimentAnalyzer.GetResponse(detectedSentiment);
                return response;
            }

            // Sentiment with a topic mentioned
            if (detectedSentiment != null && detectedTopic != null)
            {
                response += $"I see you're feeling {detectedSentiment} about {detectedTopic}.\n";
                response += SentimentAnalyzer.GetResponse(detectedSentiment) + "\n";
                response += GetRandomTip(detectedTopic);
                return response;
            }

            // Favourite topic detection
            if (input.StartsWith("i like ") || input.StartsWith("i’m interested in ") ||
                input.StartsWith("i am interested in ") || input.StartsWith("my favourite topic is "))
            {
                foreach (var topic in CyberTips.TipsByTopic.Keys)
                {
                    if (input.Contains(topic))
                    {
                        Memory.StoreFavouriteTopic(topic);
                        currentTopicKey = topic;

                        response += $"Thanks {Memory.UserName}, I'll remember that you're interested in {Memory.FavouriteTopic}.\n";
                        response += GetRandomTip(currentTopicKey);
                        return response;
                    }
                }

                return "I couldn't find that topic in my list. Try a listed topic like 'phishing' or 'password'.";
            }

            // Follow-up request
            if (IsFollowUpRequest(input))
            {
                if (!string.IsNullOrEmpty(currentTopicKey))
                {
                    response += GetRandomTip(currentTopicKey);
                }
                else
                {
                    response += "Please specify a topic first before asking for more info.";
                }

                return response;
            }

            // Topic detection
            if (input.Contains("password") || input.Contains("1"))
                currentTopicKey = "password";
            else if (input.Contains("phishing") || input.Contains("2"))
                currentTopicKey = "phishing";
            else if (input.Contains("browsing") || input.Contains("3"))
                currentTopicKey = "browsing";
            else if (input.Contains("social media") || input.Contains("4"))
                currentTopicKey = "social media";
            else if (input.Contains("wifi") || input.Contains("5"))
                currentTopicKey = "wifi";
            else if (input.Contains("malware") || input.Contains("6"))
                currentTopicKey = "malware";
            else if (input.Contains("backup") || input.Contains("7"))
                currentTopicKey = "backup";
            else if (input.Contains("two-factor") || input.Contains("2fa") || input.Contains("8"))
                currentTopicKey = "two-factor";
            else if (input.Contains("software update") || input.Contains("9"))
                currentTopicKey = "update";
            else if (input.Contains("shopping") || input.Contains("10"))
                currentTopicKey = "shopping";
            else
            {
                // Fallback: keyword match
                bool matched = false;
                foreach (var pair in CyberTips.TipsByTopic)
                {
                    if (input.Contains(pair.Key))
                    {
                        currentTopicKey = pair.Key;
                        matched = true;
                        break;
                    }
                }

                if (!matched)
                {
                    return "Sorry, I don't understand that yet. Try asking about a cybersecurity topic like 'phishing', 'password', or 'safe browsing'.";
                }
            }

            // Return tip on detected topic
            response += GetRandomTip(currentTopicKey);
            return response;
        }

        private string GetRandomTip(string topicKey)
        {
            if (string.IsNullOrEmpty(topicKey) || !CyberTips.TipsByTopic.ContainsKey(topicKey))
                return "Sorry, no tips available for that topic.";

            var tips = CyberTips.TipsByTopic[topicKey];
            if (tips.Count == 0)
                return "No tips are currently listed for this topic.";

            Random rand = new Random();
            int index = rand.Next(tips.Count);
            string header = Memory.IsFavourite(topicKey)
                ? $"🧠 Since you're interested in {topicKey}, here's a helpful tip:"
                : $"🔐 Here's a tip about {topicKey}:";

            return $"{header}\n- {tips[index]}";
        }

        private bool IsFollowUpRequest(string input)
        {
            string[] keywords = {
                "more", "another", "give me more", "tell me more", "continue",
                "elaborate", "next tip", "what else", "again", "add more"
            };

            foreach (var keyword in keywords)
            {
                if (input.Contains(keyword))
                    return true;
            }

            return false;
        }
    }
}
