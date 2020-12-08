// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/DrivingTrajectoryPoint.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__DRIVING_TRAJECTORY_POINT__STRUCT_HPP_
#define HALODI_MSGS__MSG__DRIVING_TRAJECTORY_POINT__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__DrivingTrajectoryPoint __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__DrivingTrajectoryPoint __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct DrivingTrajectoryPoint_
{
  using Type = DrivingTrajectoryPoint_<ContainerAllocator>;

  explicit DrivingTrajectoryPoint_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->x = 0.0;
      this->y = 0.0;
      this->yaw = 0.0;
      this->desired_linear_velocity = 0.0;
      this->desired_angular_velocity = 0.0;
    }
  }

  explicit DrivingTrajectoryPoint_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_alloc;
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->x = 0.0;
      this->y = 0.0;
      this->yaw = 0.0;
      this->desired_linear_velocity = 0.0;
      this->desired_angular_velocity = 0.0;
    }
  }

  // field types and members
  using _x_type =
    double;
  _x_type x;
  using _y_type =
    double;
  _y_type y;
  using _yaw_type =
    double;
  _yaw_type yaw;
  using _desired_linear_velocity_type =
    double;
  _desired_linear_velocity_type desired_linear_velocity;
  using _desired_angular_velocity_type =
    double;
  _desired_angular_velocity_type desired_angular_velocity;

  // setters for named parameter idiom
  Type & set__x(
    const double & _arg)
  {
    this->x = _arg;
    return *this;
  }
  Type & set__y(
    const double & _arg)
  {
    this->y = _arg;
    return *this;
  }
  Type & set__yaw(
    const double & _arg)
  {
    this->yaw = _arg;
    return *this;
  }
  Type & set__desired_linear_velocity(
    const double & _arg)
  {
    this->desired_linear_velocity = _arg;
    return *this;
  }
  Type & set__desired_angular_velocity(
    const double & _arg)
  {
    this->desired_angular_velocity = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__DrivingTrajectoryPoint
    std::shared_ptr<halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__DrivingTrajectoryPoint
    std::shared_ptr<halodi_msgs::msg::DrivingTrajectoryPoint_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const DrivingTrajectoryPoint_ & other) const
  {
    if (this->x != other.x) {
      return false;
    }
    if (this->y != other.y) {
      return false;
    }
    if (this->yaw != other.yaw) {
      return false;
    }
    if (this->desired_linear_velocity != other.desired_linear_velocity) {
      return false;
    }
    if (this->desired_angular_velocity != other.desired_angular_velocity) {
      return false;
    }
    return true;
  }
  bool operator!=(const DrivingTrajectoryPoint_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct DrivingTrajectoryPoint_

// alias to use template instance with default allocator
using DrivingTrajectoryPoint =
  halodi_msgs::msg::DrivingTrajectoryPoint_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__DRIVING_TRAJECTORY_POINT__STRUCT_HPP_
