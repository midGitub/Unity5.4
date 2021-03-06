﻿namespace UnityEngine
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Ray2D
    {
        private Vector2 m_Origin;
        private Vector2 m_Direction;
        public Ray2D(Vector2 origin, Vector2 direction)
        {
            this.m_Origin = origin;
            this.m_Direction = direction.normalized;
        }

        public Vector2 origin
        {
            get
            {
                return this.m_Origin;
            }
            set
            {
                this.m_Origin = value;
            }
        }
        public Vector2 direction
        {
            get
            {
                return this.m_Direction;
            }
            set
            {
                this.m_Direction = value.normalized;
            }
        }
        public Vector2 GetPoint(float distance)
        {
            return (this.m_Origin + ((Vector2) (this.m_Direction * distance)));
        }

        public override string ToString()
        {
            object[] args = new object[] { this.m_Origin, this.m_Direction };
            return UnityString.Format("Origin: {0}, Dir: {1}", args);
        }

        public string ToString(string format)
        {
            object[] args = new object[] { this.m_Origin.ToString(format), this.m_Direction.ToString(format) };
            return UnityString.Format("Origin: {0}, Dir: {1}", args);
        }
    }
}

