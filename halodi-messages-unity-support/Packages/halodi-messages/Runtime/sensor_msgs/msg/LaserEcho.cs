using System.Text;
namespace sensor_msgs.msg
{


/**
       * This message is a submessage of MultiEchoLaserScan and is not intended
       * to be used separately.
       */
[System.Serializable]
public class LaserEcho : Halodi.CDR.DataType<LaserEcho>
{

	public Halodi.CDR.TopicDataType<LaserEcho> Type => new LaserEchoPubSubType();
	
   /**
            * Multiple values of ranges or intensities.
            */
   public System.Collections.Generic.List<float> echoes;


   public void Set(LaserEcho other)
   {

      if(other.echoes == null)
      {
      	echoes = null;
      }
      else
      {
      	echoes = new System.Collections.Generic.List<float>(other.echoes.Count);
      	for(int i1 = 0; i1 < other.echoes.Count; i1++)
      	{
         		echoes.Add(other.echoes[i1]);
      	}
      }   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("LaserEcho {");
      builder.Append("echoes=");
      builder.Append(this.echoes);
      builder.Append("}");
      return builder.ToString();
   }
}


}