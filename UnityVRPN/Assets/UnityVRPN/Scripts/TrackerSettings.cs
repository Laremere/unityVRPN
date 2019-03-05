using UnityEngine;
using System.Collections;

namespace UnityVRPN
{
    public class TrackerSettings : MonoBehaviour
    {
        [SerializeField]
        private TrackerHostSettings hostSettings;
        [SerializeField]
        private string objectName = "";
        [SerializeField]
        private int channel = 0;
        [SerializeField]
        private bool trackPosition = true;
        [SerializeField]
        private bool trackRotation = true;

        public TrackerHostSettings HostSettings
        {
            get { return hostSettings; }
            set
            {
                hostSettings = value;
            }
        }

        public string ObjectName
        {
            get { return objectName; }
            set
            {
                objectName = value;
            }
        }

        public int Channel
        {
            get { return channel; }
            set
            {
                channel = value;
            }
        }

        public bool TrackPosition
        {
            get { return trackPosition; }
            set
            {
                trackPosition = value;
                StopCoroutine("Position");
                if (trackPosition && Application.isPlaying)
                {
                    StartCoroutine("Position");
                }
            }
        }

        public bool TrackRotation
        {
            get { return trackRotation; }
            set
            {
                trackRotation = value;
                StopCoroutine("Rotation");
                if (trackRotation && Application.isPlaying)
                {
                    StartCoroutine("Rotation");
                }
            }
        }

        private void Start()
        {
            if (trackPosition)
            {
                StartCoroutine("Position");
            }

            if (trackRotation)
            {
                StartCoroutine("Rotation");
            }
        }

        private IEnumerator Position()
        {
            while (true)
            {
                transform.position = hostSettings.GetPosition(objectName, channel);
                yield return null;
            }
        }

        private IEnumerator Rotation()
        {
            while (true)
            {
                transform.rotation = hostSettings.GetRotation(objectName, channel);
                yield return null;
            }
        }
    }
}
