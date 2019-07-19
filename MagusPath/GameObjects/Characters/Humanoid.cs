using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagusPath
{
    public class Humanoid: Character
    {
        public Humanoid( string name )
            :base(name)
        {
            body = new Body( "Torso", new List<Body>(new Body[] {
                new Body( "Neck", new List<Body>(new Body[] {
                    CreateHead()
                }) ),
                new Body( "Shoulders", new List<Body>(new Body[] {
                    new Body( "Upper Left Arm", new List<Body>(new Body[] {
                        new Body( "Lower Left Arm", new List<Body>(new Body[] {
                            CreateHand("Left", "Finger", true)
                        }) )
                    }) ),
                    new Body( "Upper Right Arm", new List<Body>(new Body[] {
                        new Body( "Lower Right Arm", new List<Body>(new Body[] {
                            CreateHand("Right", "Finger", true)
                        }) )
                    }) )
                }) ),
                new Body( "Hips", new List<Body>(new Body[] {
                    new Body( "Upper Left Leg", new List<Body>(new Body[] {
                        new Body( "Lower Left Leg", new List<Body>(new Body[] {
                            CreateHand("Left", "Toe", false)
                        }) )
                    }) ),
                    new Body( "Upper Right Leg", new List<Body>(new Body[] {
                        new Body( "Lower Right Leg", new List<Body>(new Body[] {
                            CreateHand("Right", "Toe", false)
                        }) )
                    }) )
                }) )
            }) );
        }

        Body CreateHand(string side, string phalangeName, bool canGrasp)
        {
            Body hand =
                new Body( $"{side} Hand", new List<Body>(new Body[] {
                    new Body( $"{side} Thumb {phalangeName}", new List<Body>() ),
                    new Body( $"{side} Index {phalangeName}", new List<Body>() ),
                    new Body( $"{side} Middle {phalangeName}", new List<Body>() ),
                    new Body( $"{side} Ring {phalangeName}", new List<Body>() ),
                    new Body( $"{side} Little {phalangeName}", new List<Body>() )
                }) );

            return hand;
        }

        Body CreateHead()
        {
            Body head = 
            new Body( "Head", new List<Body>(new Body[] {
                new Body( "Mouth", new List<Body>()),
                new Body( "Nose", new List<Body>()),
                new Body( "Left Eye", new List<Body>()),
                new Body( "Right Eye", new List<Body>()),
                new Body( "Left Ear", new List<Body>()),
                new Body( "Right Ear", new List<Body>())
            }) );

            return head;
        }
    }
}
