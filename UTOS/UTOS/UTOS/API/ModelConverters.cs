using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.DataModels;
using Xamarin.Forms;

namespace UTOS.API
{
    public class ModelConverters
    {
        public static SpeakerDM ConvertSpeakerTODM(Speaker speaker)
        {
            var speakerdm = new SpeakerDM
            {
                Name = speaker.name?.Trim(),
                Twitter = speaker.twitter?.Trim(),
            };

            var imageURI = "";
            if (!string.IsNullOrEmpty(speaker.gravatar_hash))
            {
                imageURI = Resources.GravatarBaseURL + speaker.gravatar_hash.Trim() + Resources.GravatarEnding;
                speakerdm.GravatarImageString = imageURI;
                //speakerdm.GravatarImageSource = ImageSource.FromUri(new Uri(imageURI));
            }

            return speakerdm;
        }

        public static SessionDM ConvertTalkToDM(Talk talk)
        {
            var speaker = ConvertSpeakerTODM(talk.speakers.First());
            var session = new SessionDM
            {
                TalkId = talk.talkid,
                DateAndTime = talk.ts.ToString(),
                Description = talk.description?.Trim(),
                Title = talk.title?.Trim(),
                Speaker = speaker,
                Date = talk.date?.Trim(),
                Time = talk.time?.Trim(),
                Track = talk.track?.Trim(),
            };
            return session;
        }
    }
}
