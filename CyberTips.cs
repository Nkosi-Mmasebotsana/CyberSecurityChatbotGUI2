using System.Collections.Generic;

namespace CyberSecurityChatbot
{
    public static class CyberTips //class handles all the cyber security random tips
    {
        public static Dictionary<string, List<string>> TipsByTopic = new Dictionary<string, List<string>>
        {
            ["password"] = new List<string>
            {
                "Use long, complex passwords (at least 12 characters).",
                "Never reuse passwords across accounts.",
                "Consider using a reputable password manager.",
                "Avoid using personal info like birthdays or names in passwords.",
                "Change passwords immediately after a data breach.",
                "Don't write passwords down or share them with others."
            },

            ["phishing"] = new List<string>
            {
                "Never click links or download attachments from suspicious emails.",
                "Check sender email addresses carefully for subtle misspellings.",
                "Be wary of urgent requests for personal/financial information.",
                "Scammers often impersonate banks or delivery companies.",
                "Hover over links to see the actual URL before clicking.",
                "If in doubt, contact the sender through a trusted channel."
            },

            ["browsing"] = new List<string>
            {
                "Look for HTTPS and the padlock icon in the address bar.",
                "Avoid downloading files from unknown websites.",
                "Clear your cache and cookies regularly.",
                "Install ad-blockers and anti-tracking extensions.",
                "Use secure, privacy-focused browsers when possible.",
                "Avoid clicking pop-up ads and suspicious links."
            },

            ["social media"] = new List<string>
            {
                "Review and update privacy settings frequently.",
                "Be careful about posting personal details or locations.",
                "Avoid accepting friend requests from strangers.",
                "Limit app access to your social accounts.",
                "Don’t overshare information that can be used for identity theft.",
                "Think before posting photos with location or private details."
            },

            ["wifi"] = new List<string>
            {
                "Avoid using public Wi-Fi for sensitive activities.",
                "Use a VPN when connecting to unknown networks.",
                "Turn off file sharing in public places.",
                "Double-check network names with staff to avoid fake hotspots.",
                "Set your device to forget public networks after use.",
                "Avoid entering passwords or banking info on public networks."
            },

            ["malware"] = new List<string>
            {
                "Install and update antivirus software regularly.",
                "Avoid clicking suspicious ads or pop-ups.",
                "Don't open email attachments from unknown senders.",
                "Be careful with USB drives and downloads.",
                "Scan downloaded files before opening.",
                "Keep your operating system up to date."
            },

            ["backup"] = new List<string>
            {
                "Follow the 3-2-1 backup rule: 3 copies, 2 types, 1 offsite.",
                "Use automated backup tools to avoid forgetting.",
                "Test your backups occasionally to ensure they work.",
                "Consider cloud storage for offsite backups.",
                "Keep physical backups (USBs, drives) in secure places.",
                "Encrypt sensitive files before backing them up."
            },

            ["two-factor"] = new List<string>
            {
                "Enable 2FA on all major accounts.",
                "Prefer authenticator apps over SMS codes.",
                "Store backup codes in a secure place.",
                "Be wary of unexpected 2FA prompts.",
                "Don’t approve login requests you didn’t initiate.",
                "Use hardware keys for maximum 2FA security if possible."
            },

            ["update"] = new List<string>
            {
                "Enable auto-updates for your OS and apps.",
                "Update third-party software regularly.",
                "Remove unused software to reduce attack surface.",
                "Keep firmware (like your router) up to date.",
                "Install security patches as soon as they’re released.",
                "Restart your device after updates to complete installations."
            },

            ["shopping"] = new List<string>
            {
                "Shop on trusted, HTTPS-secured websites.",
                "Use credit cards for better fraud protection.",
                "Avoid shopping on public Wi-Fi networks.",
                "Regularly check your bank statements for fraud.",
                "Never save card details on shopping sites you rarely use.",
                "Beware of fake online stores offering unrealistic discounts."
            }
        };
    }
}
