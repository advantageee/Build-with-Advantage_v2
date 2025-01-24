using System;
using System.Collections.Generic;

namespace AdvantageAIWeb.Models.Chat
{
    public class StreamedChatResponse
    {
        public List<StreamedChoice> Choices { get; private set; }

        public StreamedChatResponse()
        {
            Choices = new List<StreamedChoice>();
        }

        public void AddChoice(StreamedChoice choice)
        {
            if (choice == null)
            {
                throw new ArgumentNullException(nameof(choice), "Choice cannot be null.");
            }

            if (choice.Delta == null)
            {
                throw new ArgumentException("Delta cannot be null in a choice.", nameof(choice));
            }

            Choices.Add(choice);
        }

        public void ClearChoices()
        {
            Choices.Clear();
        }

        public void Validate()
        {
            if (Choices == null || Choices.Count == 0)
            {
                throw new InvalidOperationException("Choices must contain at least one item.");
            }

            foreach (var choice in Choices)
            {
                if (choice.Delta == null)
                {
                    throw new InvalidOperationException("Each choice must have a valid Delta.");
                }

                if (string.IsNullOrWhiteSpace(choice.Delta.Role))
                {
                    throw new InvalidOperationException("Delta role cannot be null or empty.");
                }

                if (string.IsNullOrWhiteSpace(choice.Delta.Content))
                {
                    throw new InvalidOperationException("Delta content cannot be null or empty.");
                }
            }
        }

        public class StreamedChoice
        {
            public StreamedDelta Delta { get; set; }
        }

        public class StreamedDelta
        {
            public string Role { get; set; }
            public string Content { get; set; }
        }
    }
}
