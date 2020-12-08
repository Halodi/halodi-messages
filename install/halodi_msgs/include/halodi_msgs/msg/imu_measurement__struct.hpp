// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/ImuMeasurement.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__IMU_MEASUREMENT__STRUCT_HPP_
#define HALODI_MSGS__MSG__IMU_MEASUREMENT__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'imu'
#include "halodi_msgs/msg/imu_name__struct.hpp"
// Member 'orientation'
#include "geometry_msgs/msg/quaternion__struct.hpp"
// Member 'angular_velocity'
// Member 'linear_acceleration'
#include "geometry_msgs/msg/vector3__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__ImuMeasurement __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__ImuMeasurement __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct ImuMeasurement_
{
  using Type = ImuMeasurement_<ContainerAllocator>;

  explicit ImuMeasurement_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : imu(_init),
    orientation(_init),
    angular_velocity(_init),
    linear_acceleration(_init)
  {
    (void)_init;
  }

  explicit ImuMeasurement_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : imu(_alloc, _init),
    orientation(_alloc, _init),
    angular_velocity(_alloc, _init),
    linear_acceleration(_alloc, _init)
  {
    (void)_init;
  }

  // field types and members
  using _imu_type =
    halodi_msgs::msg::ImuName_<ContainerAllocator>;
  _imu_type imu;
  using _orientation_type =
    geometry_msgs::msg::Quaternion_<ContainerAllocator>;
  _orientation_type orientation;
  using _angular_velocity_type =
    geometry_msgs::msg::Vector3_<ContainerAllocator>;
  _angular_velocity_type angular_velocity;
  using _linear_acceleration_type =
    geometry_msgs::msg::Vector3_<ContainerAllocator>;
  _linear_acceleration_type linear_acceleration;

  // setters for named parameter idiom
  Type & set__imu(
    const halodi_msgs::msg::ImuName_<ContainerAllocator> & _arg)
  {
    this->imu = _arg;
    return *this;
  }
  Type & set__orientation(
    const geometry_msgs::msg::Quaternion_<ContainerAllocator> & _arg)
  {
    this->orientation = _arg;
    return *this;
  }
  Type & set__angular_velocity(
    const geometry_msgs::msg::Vector3_<ContainerAllocator> & _arg)
  {
    this->angular_velocity = _arg;
    return *this;
  }
  Type & set__linear_acceleration(
    const geometry_msgs::msg::Vector3_<ContainerAllocator> & _arg)
  {
    this->linear_acceleration = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::ImuMeasurement_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::ImuMeasurement_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::ImuMeasurement_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::ImuMeasurement_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ImuMeasurement_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ImuMeasurement_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ImuMeasurement_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ImuMeasurement_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::ImuMeasurement_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::ImuMeasurement_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__ImuMeasurement
    std::shared_ptr<halodi_msgs::msg::ImuMeasurement_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__ImuMeasurement
    std::shared_ptr<halodi_msgs::msg::ImuMeasurement_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const ImuMeasurement_ & other) const
  {
    if (this->imu != other.imu) {
      return false;
    }
    if (this->orientation != other.orientation) {
      return false;
    }
    if (this->angular_velocity != other.angular_velocity) {
      return false;
    }
    if (this->linear_acceleration != other.linear_acceleration) {
      return false;
    }
    return true;
  }
  bool operator!=(const ImuMeasurement_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct ImuMeasurement_

// alias to use template instance with default allocator
using ImuMeasurement =
  halodi_msgs::msg::ImuMeasurement_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__IMU_MEASUREMENT__STRUCT_HPP_
