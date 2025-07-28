using System.Collections.Generic;

namespace CyberSecurityChatbotGUI
{
    internal static class QuizData
    {
        public static List<QuizQuestion> GetQuestions()
        {
            return new List<QuizQuestion>
            {
                new QuizQuestion("What is phishing?", new[] {
                    "A cyberattack that tricks users into giving up personal info",
                    "A type of software update",
                    "A method of encrypting data",
                    "A legitimate email from your boss"
                }, 0, "Phishing is a cyberattack that tricks users into giving up personal info."),

                new QuizQuestion("Which is a strong password?", new[] {
                    "123456",
                    "Password1",
                    "Qx!3p$Z9@t",
                    "abcdef"
                }, 2, "Strong passwords are complex and hard to guess, like 'Qx!3p$Z9@t'."),

                new QuizQuestion("Which of the following is a common sign of malware?", new[] {
                    "Faster computer performance",
                    "Pop-up ads and crashes",
                    "Louder fan noise",
                    "Shorter battery life"
                }, 1, "Pop-up ads and crashes are common signs of malware infection."),

                new QuizQuestion("What does 2FA stand for?", new[] {
                    "Two-Factor Authentication",
                    "Two File Access",
                    "Fast Access Approval",
                    "Trusted Firewall Application"
                }, 0, "2FA stands for Two-Factor Authentication, adding extra security."),

                new QuizQuestion("What is ransomware?", new[] {
                    "A backup tool",
                    "A program that demands payment to unlock files",
                    "An antivirus software",
                    "A type of firewall"
                }, 1, "Ransomware is malware that demands payment to unlock your files."),

                // Additional 5 descriptive, educational questions:

                new QuizQuestion("Why should you avoid using public Wi-Fi for sensitive tasks?", new[] {
                    "Because it's slower",
                    "Because it might be insecure and expose your data",
                    "Because you can't access websites",
                    "Because it uses more battery"
                }, 1, "Public Wi-Fi can be insecure, exposing your data to hackers."),

                new QuizQuestion("What is the purpose of a firewall?", new[] {
                    "To cool down your computer",
                    "To block unauthorized access to your network",
                    "To update your software",
                    "To speed up internet connection"
                }, 1, "A firewall blocks unauthorized access and protects your network."),

                new QuizQuestion("How often should you update your software?", new[] {
                    "Only when it stops working",
                    "Regularly to patch security vulnerabilities",
                    "Once a year",
                    "Never"
                }, 1, "Regular updates patch security flaws and protect against threats."),

                new QuizQuestion("What does 'HTTPS' in a website URL mean?", new[] {
                    "HyperText Transfer Protocol Secure",
                    "High Tech Transfer Protocol Service",
                    "Hyper Terminal Protocol Server",
                    "Home Transfer Protocol Standard"
                }, 0, "HTTPS means your connection is encrypted and secure."),

                new QuizQuestion("Why is it important to use unique passwords for different accounts?", new[] {
                    "To make passwords easier to remember",
                    "Because reusing passwords risks multiple accounts if one is hacked",
                    "To speed up login",
                    "To reduce password length"
                }, 1, "Unique passwords prevent attackers from accessing multiple accounts if one is compromised."),
            };
        }
    }
}
