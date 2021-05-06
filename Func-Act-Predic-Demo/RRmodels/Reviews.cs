using System;
namespace RRmodels
{
    public class Reviews
    {

/// <summary>
/// review contructor
/// </summary>
/// <param name="_valueRating"></param>
/// to pass into the ValueRating Property
/// <param name="_qualityRating"></param>
/// /// to pass into the QualityRating Property
/// <param name="_atmosphereRating"></param>
/// /// to pass into the AtmosphereRating Property
        public Reviews (float _valueRating, float _qualityRating, float _atmosphereRating)
        {
            ValueRating = _valueRating;
            QualityRating = _qualityRating;
            AtmosphereRating = _atmosphereRating;
        }
        /// <summary>
        /// This described the numerical value of the value rating of the restaurant
        /// </summary>
        /// <value></value>
        public float ValueRating { get; set; }

        /// <summary>
        /// This described the numerical value of the food quality rating of the restaurant
        /// </summary>
        /// <value></value>
        public float QualityRating { get; set; }
                /// <summary>
        /// This described the numerical value of the atmosphere rating of the restaurant
        /// </summary>
        /// <value></value>
        public float AtmosphereRating { get; set; }

        /// <summary>
        /// This described the reasoning for the given Rating value based on experience
        /// </summary>
        /// <value></value>
        public string Description { get; set; }

/// <summary>
/// The following Function allows us to average the three indivudual ratings without creating another property. We can pass this directly into the ToString without having to call a 
/// function or create another property.
/// </summary>
/// <returns></returns>
Func<float, float, float, float> reviewAverage = (x, y, z) => ((x + y + z)/ 3); 

        public override string ToString()
        {
            return $"\n\t Rating: {reviewAverage(ValueRating, QualityRating, AtmosphereRating)} \n\t Description: {Description}";
        }
    }
}