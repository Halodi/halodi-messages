using System.Text;
namespace sensor_msgs.msg
{


/**
       * Reports the state of a joystick's axes and buttons.
       */
[System.Serializable]
public class Joy : Halodi.CDR.DataType<Joy>
{

	public Halodi.CDR.TopicDataType<Joy> Type => new JoyPubSubType();
	
   /**
            * The timestamp is the time at which data is received from the joystick.
            */
   public std_msgs.msg.Header header;
   /**
            * The axes measurements from a joystick.
            */
   public System.Collections.Generic.List<float> axes;
   /**
            * The buttons measurements from a joystick.
            */
   public System.Collections.Generic.List<int> buttons;


   public void Set(Joy other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);


      if(other.axes == null)
      {
      	axes = null;
      }
      else
      {
      	axes = new System.Collections.Generic.List<float>(other.axes.Count);
      	for(int i1 = 0; i1 < other.axes.Count; i1++)
      	{
         		axes.Add(other.axes[i1]);
      	}
      }

      if(other.buttons == null)
      {
      	buttons = null;
      }
      else
      {
      	buttons = new System.Collections.Generic.List<int>(other.buttons.Count);
      	for(int i2 = 0; i2 < other.buttons.Count; i2++)
      	{
         		buttons.Add(other.buttons[i2]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Joy {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("axes=");
      builder.Append(this.axes);      builder.Append(", ");
      builder.Append("buttons=");
      builder.Append(this.buttons);
      builder.Append("}");
      return builder.ToString();
   }
}


}